namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.Core.Resources;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;
    using MaintenanceManagement.Web.Resources;

    public class ProjectsController : BaseApiController
    {
        public IEnumerable<ProjectGetModel> Get()
        {
            var isAdmin = User.IsInRole(CmmRoles.Administrator);

            return
                MainContext.Projects.Include(p => p.BoardA.Tasks)
                    .Include(p => p.BoardB.Tasks)
                    .Include(p => p.BoardC.Tasks)
                    .OrderBy(a => a.Name)
                    .Where(p => isAdmin || p.Owner.Login == User.Identity.Name)
                    .ToList()
                    .Select(
                        a =>
                        new ProjectGetModel
                        {
                            Id = a.Id,
                            Name = a.Name,
                            DueDate = a.DueDate.ToCmmDate(),
                            Progress = this.GetProjectProgress(a),
                            Area = a.Area == null ? null : new IdNamePair { Id = a.Area.Id, Name = a.Area.Name },
                            Description = a.Description,
                            Owner =
                                a.Owner == null
                                    ? null
                                    : new IdNamePair { Id = a.Owner.Id, Name = a.Owner.FullName(a.Owner) },
                            ProjectNumber = a.ProjectNumber,
                        })
                    .ToList();
        }

        [Authorize(Roles = CmmRoles.Administrator)]
        public async Task<BasePutResponse> Put(ProjectPutModel model)
        {
            await MainContext.Update<Project, ProjectPutModel>(
                model,
                (m, e) =>
                {
                    e.Area = MainContext.Areas.Single(a => a.Id == model.Area.Id);
                    e.DueDate = model.DueDate.ParseDateTime().GetValueOrDefault();
                    e.Name = model.Name;
                    e.Owner = MainContext.Employees.Single(x => x.Id == model.Owner.Id);
                    e.ProjectNumber = model.ProjectNumber;
                    e.Description = model.Description;
                });

            return new BasePutResponse();
        }

        [Authorize(Roles = CmmRoles.Administrator)]
        public async Task<BasePostResponse> Post(ProjectPostModel model)
        {
            var project = new Project
            {
                Area = MainContext.Areas.Single(a => a.Id == model.Area.Id),
                DueDate = model.DueDate.ParseDateTime().GetValueOrDefault(),
                Name = model.Name,
                Owner = MainContext.Employees.Single(x => x.Id == model.Owner.Id),
                ProjectNumber = model.ProjectNumber,
                BoardA = new TaskBoard(),
                BoardB = new TaskBoard(),
                BoardC = new TaskBoard(),
                Description = model.Description
            };

            var id = await MainContext.Insert(project);

            this.AddTaskToBoard(project, project.BoardA, "AA 09-47-Vorl 1 Startup of project evaluation");
            this.AddTaskToBoard(project, project.BoardA, "AA 09-47-Vorl 2 Close out of project evaluation");

            this.AddTaskToBoard(project, project.BoardB, "AA 09-47-Vorl 3 Project Order");
            this.AddTaskToBoard(project, project.BoardB, "URS");
            this.AddTaskToBoard(project, project.BoardB, "Oferty");
            this.AddTaskToBoard(project, project.BoardB, "CRF");
            this.AddTaskToBoard(project, project.BoardB, "FMEA");

            this.AddTaskToBoard(project, project.BoardC, "FAT");
            this.AddTaskToBoard(project, project.BoardC, "SAT");
            this.AddTaskToBoard(project, project.BoardC, "kwalifikacja/walidacja");
            this.AddTaskToBoard(project, project.BoardC, "CRF - close out");
            this.AddTaskToBoard(project, project.BoardC, "AA 09-47-Vorl 4 Project Close out");

            await MainContext.SaveChangesAsync();

            return new BasePostResponse { Id = id };
        }

        [Authorize(Roles = CmmRoles.Administrator)]
        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Project>(id);
            return new BaseDeleteResponse();
        }

        private void AddTaskToBoard(Project project, TaskBoard board, string taskName)
        {
            MainContext.EmployeeTasks.Add(
                new EmployeeTask
                {
                    Area = project.Area,
                    Assignee = project.Owner,
                    Board = board,
                    DueDate = project.DueDate,
                    Progress = 0,
                    Status = EmployeeTaskStatus.Planned,
                    Subject = taskName
                });
        }

        private string GetProjectProgress(Project project)
        {
            var result = string.Empty;

            if (project.BoardA != null && project.BoardB != null && project.BoardC != null)
            {
                result = project.BoardA.IsFinished && project.BoardB.IsFinished && project.BoardC.IsFinished
                             ? WebCommon.ProjectFinished
                             : project.BoardC.IsInProgress
                                   ? WebCommon.TaskBoardC_Name
                                   : project.BoardB.IsInProgress
                                         ? WebCommon.TaskBoardB_Name
                                         : project.BoardA.IsInProgress ? WebCommon.TaskBoardA_Name : string.Empty;
            }

            return result;
        }
    }
}
