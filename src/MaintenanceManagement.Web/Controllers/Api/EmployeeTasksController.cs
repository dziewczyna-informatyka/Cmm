namespace MaintenanceManagement.Web.Controllers.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;

    public class EmployeeTasksController : BaseApiController
    {
        public IEnumerable<EmployeeTaskGetModel> Get()
        {
            return
                MainContext.EmployeeTasks.OrderByDescending(a => a.DueDate)
                    .ToList()
                    .Select(
                        a =>
                        new EmployeeTaskGetModel
                        {
                            Id = a.Id,
                            Area = new IdNamePair { Id = a.Area.Id, Name = a.Area.Name },
                            Actions = a.Actions,
                            Assignee = new IdNamePair { Id = a.Assignee.Id, Name = a.Assignee.Name },
                            DueDate = a.DueDate.ToCmmDate(),
                            Progress = a.Progress,
                            Status = a.Status.ToIdNamePair(),
                            Subject = a.Subject
                        });
        }

        public async Task<BasePutResponse> Put(EmployeeTaskPutModel model)
        {
            await MainContext.Update<EmployeeTask, EmployeeTaskPutModel>(
                model,
                (m, e) =>
                    {
                        e.Actions = m.Actions;
                        e.Area = MainContext.Areas.Single(a => a.Id == m.Area.Id);
                        e.DueDate = m.DueDate.ParseDateTime().GetValueOrDefault();
                        e.Progress = m.Progress;
                        e.Status = EnumExtensions.FromIdNamePair<EmployeeTaskStatus>(m.Status).GetValueOrDefault();
                        e.Subject = m.Subject;

                        // TODO: Roles
                        e.Assignee = MainContext.Employees.Single(x => x.Id == m.Assignee.Id);
                        e.ActualEndDate = e.Status == EmployeeTaskStatus.Done ? DateTime.Now : e.ActualEndDate;
                    });

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(EmployeeTaskPostModel model)
        {
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

                        // TODO: Roles
                        Assignee = MainContext.Employees.Single(x => x.Id == model.Assignee.Id)
                    });

            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<EmployeeTask>(id);
            return new BaseDeleteResponse();
        }
    }
}
