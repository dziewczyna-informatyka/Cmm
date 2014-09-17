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

                scope.customActionsCount = (scope.customActions || []).length;
                scope.currentEntity = null;

                apiClient.get(scope.resource).then(function (data) {
                    scope.dataSource = data;
                });

                // Methods definitions

                scope.checkPermission = function (level) {                    
                    return !level || !scope.editRole || CmmAuth.roles.indexOf(scope.editRole) != -1;
                };

                scope.columnFilter = function(v, i) {
                    return !v.isHidden;
                };

                scope.resolveField = function(model, s) {
                    return scope.$eval('m.' + (s.displayField || s.field), { m: model });
                };

                scope.onAddClick = function () {
                    scope.currentEntity = {};
                    openEditor(WebCommon.Add);
                };

                scope.onEditClick = function (entity) {
                    scope.currentEntity = $.extend({}, entity, true);
                    openEditor(WebCommon.Edit);
                };

                scope.onDeleteClick = function (entity) {                    
                    EditorHelper.remove(apiClient, scope.resource, entity, scope.dataSource);
                };

                scope.onSaveClick = function() {
                    EditorHelper.save(apiClient, scope.resource, scope.currentEntity, scope.dataSource);
                };

                scope.invokeCustomAction = function(action, entity) {
                    if (action.redirect) {
                        window.location = action.redirect.replace('{id}', entity.id);
                    }
                };
            },
            scope: {
                resource: '@',
                schema: '=',
                customActions: '=',
                editRole: '@'
            },
            restrict: 'E',
            templateUrl: '/Template/Grid'
        }
    }]);
}());