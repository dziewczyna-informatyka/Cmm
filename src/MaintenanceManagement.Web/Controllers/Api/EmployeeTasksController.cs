namespace MaintenanceManagement.Web.Controllers.Api
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    public class EmployeeTasksController : BaseApiController
    {
        public IEnumerable<EmployeeTaskGetModel> Get(int? boardId = null)
        {
            var isAdmin = User.IsInRole(CmmRoles.Administrator);

            return
                MainContext.EmployeeTasks.Where(t => isAdmin || t.Assignee.Login == User.Identity.Name)
                    .OrderByDescending(a => a.DueDate)
                    .Where(t => t.Board.Id == boardId || (t.Board == null && boardId == null))
                    .ToList()
                    .Select(
                        a =>
                        new EmployeeTaskGetModel
                        {
                            Id = a.Id,
                            Area = new IdNamePair { Id = a.Area.Id, Name = a.Area.Name },
                            Actions = a.Actions,
                            Assignee = new IdNamePair { Id = a.Assignee.Id, Name = a.Assignee.FullName(a.Assignee) },
                            DueDate = a.DueDate.ToCmmDate(),
                            Progress = a.Progress,
                            Status = a.Status.ToIdNamePair(),
                            Subject = a.Subject
                        });
        }

        public async Task<EmployeeTaskPutResponseModel> Put(EmployeeTaskPutModel model)
        {
            await this.CheckAssignee(model.Assignee);

            var task = await MainContext.Update<EmployeeTask, EmployeeTaskPutModel>(
                model,
                (m, e) =>
                {
                    e.Actions = m.Actions;
                    e.Area = MainContext.Areas.Single(a => a.Id == m.Area.Id);
                    e.DueDate = m.DueDate.ParseDateTime().GetValueOrDefault();
                    e.Progress = m.Progress;
                    e.Subject = m.Subject;
                    e.Assignee = MainContext.Employees.Single(x => x.Id == m.Assignee.Id);

                    var newStatus = EnumExtensions.FromIdNamePair<EmployeeTaskStatus>(m.Status);
                    e.Status = newStatus == null ? e.Status : newStatus.Value;

                    if (newStatus != null)
                    {
                        if (e.Status == EmployeeTaskStatus.Done)
                        {
                            e.ActualEndDate = DateTime.Now;
                            e.Progress = 100;
                        }

                        if (e.Status == EmployeeTaskStatus.Planned)
                        {
                            e.Progress = 0;
                        }
                    }
                });

            return new EmployeeTaskPutResponseModel { Progress = task.Progress };
        }

        public async Task<BasePostResponse> Post(EmployeeTaskPostModel model)
        {
            await this.CheckAssignee(model.Assignee);

            var id =
                await
                MainContext.Insert(
                    new EmployeeTask
                    {
                        Actions = model.Actions,
                        Area = MainContext.Areas.Single(a => a.Id == model.Area.Id),
                        DueDate = model.DueDate.ParseDateTime().GetValueOrDefault(),
                        Progress = model.Progress,
                        Status = EmployeeTaskStatus.Planned,
                        Subject = model.Subject,
                        Board = model.Board == null ? null : MainContext.TaskBoards.Single(b => b.Id == model.Board.Id),
                        Assignee =
                            this.User.IsInRole(CmmRoles.Administrator)
                                ? this.MainContext.Employees.Single(x => x.Id == model.Assignee.Id)
                                : this.MainContext.Employees.Single(x => x.Login == this.User.Identity.Name)
                    });

            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<EmployeeTask>(id);
            return new BaseDeleteResponse();
        }

        private async Task CheckAssignee(IdNamePair assignee)
        {
            var currentUser = await MainContext.Employees.SingleAsync(x => x.Login == User.Identity.Name);

            if (!User.IsInRole(CmmRoles.Administrator)
                && (assignee == null || assignee.Id != currentUser.Id))
            {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
        }
    }
}
