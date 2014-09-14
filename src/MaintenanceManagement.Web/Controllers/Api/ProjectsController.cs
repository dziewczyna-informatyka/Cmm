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
                            Progress = "2"
                        });
        }

        public async Task<BasePutResponse> Put(ProjectPutModel model)
        {
            await MainContext.Update<Project, ProjectPutModel>(
                model,
                (m, e) =>
                    {
                        e.DueDate = model.DueDate.ParseDateTime().GetValueOrDefault();
                        e.Name = model.Name;
                    });

            return new BasePutResponse();
        }

        public async Task<BasePostResponse> Post(ProjectPostModel model)
        {
            var id =
                await
                MainContext.Insert(
                    new Project { DueDate = model.DueDate.ParseDateTime().GetValueOrDefault(), Name = model.Name });

            return new BasePostResponse { Id = id };
        }

        public async Task<BaseDeleteResponse> Delete(int id)
        {
            await MainContext.DeleteById<Project>(id);
            return new BaseDeleteResponse();
        }
    }
}
