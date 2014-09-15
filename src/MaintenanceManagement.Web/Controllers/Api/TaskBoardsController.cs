namespace MaintenanceManagement.Web.Controllers.Api
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;
    using MaintenanceManagement.Web.Core;
    using MaintenanceManagement.Web.Models.Api;
    using MaintenanceManagement.Web.Resources;

    public class TaskBoardsController : BaseApiController
    {
        public async Task<IEnumerable<TaskBoardGetModel>> Get(int projectId)
        {
            var project = await MainContext.Projects.SingleAsync(p => p.Id == projectId);

            return
                new[]
                {
                    project.BoardA == null
                        ? null
                        : new TaskBoardGetModel { Id = project.BoardA.Id, Name = WebCommon.TaskBoardA_Name },
                    project.BoardB == null
                        ? null
                        : new TaskBoardGetModel { Id = project.BoardB.Id, Name = WebCommon.TaskBoardB_Name },
                    project.BoardC == null
                        ? null
                        : new TaskBoardGetModel { Id = project.BoardC.Id, Name = WebCommon.TaskBoardC_Name }
                }.Where(
                    x => x != null).ToList();
        }
    }
}
