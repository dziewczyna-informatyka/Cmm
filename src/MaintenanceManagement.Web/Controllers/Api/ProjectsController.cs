namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;
    using MaintenanceManagement.Web.Resources;

    public class ProjectsController : BaseApiController
    {
        public IEnumerable<ProjectGetModel> Get()
        {
            return
                MainContext.Projects.OrderBy(a => a.Name)
                    .ToList()
                    .Select(
                        a =>
                        new ProjectGetModel
                        {
                            Id = a.Id,
                            Name = a.Name,
                            DueDate = a.DueDate.ToCmmDate(),
                            Progress = "2",
                            Area = a.Area == null ? null : new IdNamePair { Id = a.Area.Id, Name = a.Area.Name },
                            Owner = a.Owner == null ? null : new IdNamePair { Id = a.Owner.Id, Name = a.Owner.FullName(a.Owner) },
                            ProjectNumber = a.ProjectNumber,
                            BoardA = a.BoardA == null ? null : new IdNamePair { Id = a.BoardA.Id, Name = WebCommon.TaskBoardA_Name },
                            BoardB = a.BoardB == null ? null : new IdNamePair { Id = a.BoardB.Id, Name = WebCommon.TaskBoardB_Name },
                            BoardC = a.BoardC == null ? null : new IdNamePair { Id = a.BoardC.Id, Name = WebCommon.TaskBoardC_Name },
                        })
                    .ToList();
        }

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
                });

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(ProjectPostModel model)
        {
            var id =
                await
                MainContext.Insert(
                    new Project
                    {
                        Area = MainContext.Areas.Single(a => a.Id == model.Area.Id),
                        DueDate = model.DueDate.ParseDateTime().GetValueOrDefault(),
                        Name = model.Name,
                        Owner = MainContext.Employees.Single(x => x.Id == model.Owner.Id),
                        ProjectNumber = model.ProjectNumber,
                        BoardA = new TaskBoard(),
                        BoardB = new TaskBoard(),
                        BoardC = new TaskBoard()
                    });

            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Project>(id);
            return new BaseDeleteResponse();
        }
    }
}
