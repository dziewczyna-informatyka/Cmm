(function () {
    'use strict';

    cmmApp.directive('cmmGrid', ['apiClient', function (apiClient) {
        return {
            link: function (scope, element, attrs) {
                var modal = $(element).find('#editor'),
                    openEditor = function (title) {
                        modal.find('.modal-title').text(title);
                        modal.modal({ show: true });
                    };

                apiClient.read(scope.resource).then(function (data) {
                    scope.dataSource = data;
                });


                scope.onEditClick = function (entity) {
                    openEditor(WebCommon.Edit);
                };

                scope.onDeleteClick = function (entity) {
                    if (confirm(WebCommon.ConfirmDelete)) {
                        apiClient.delete(scope.resource, entity.id).then(function () {
                            scope.dataSource.splice(scope.dataSource.indexOf(entity), 1);
                        });
                    }
                };

                scope.onAddClick = function (entity) {
                    openEditor(WebCommon.Add);
                };
            },
            scope: {
                resource: '=resource',
                schema: '=schema'
            },
            restrict: 'E',
            templateUrl: '/Template/Grid'
        }
    }]);
}());