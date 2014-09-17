var EditorHelper = (function() {
    'use strict';    

    return {        
        remove: function(apiClient, resource, entity, dataSource) {
            if (confirm(WebCommon.ConfirmDelete)) {
                return apiClient.delete(resource, entity.id).then(function() {
                    dataSource.splice(dataSource.indexOf(entity), 1);
                });
            }
        },
        save: function(apiClient, resource, editedEntity, dataSource) {
            if (editedEntity.id) {
                return apiClient.put(resource, editedEntity).then(function() {
                    var e = null;

                    for (var i in dataSource) {
                        if (dataSource[i].id == editedEntity.id) {
                            e = dataSource[i];
                        }
                    }

                    $.extend(e, editedEntity, true);
                });
            } else {
                return apiClient.post(resource, editedEntity).then(function(data) {
                    editedEntity.id = data.id;
                    dataSource.push(editedEntity);
                });
            }
        }
    };
}());