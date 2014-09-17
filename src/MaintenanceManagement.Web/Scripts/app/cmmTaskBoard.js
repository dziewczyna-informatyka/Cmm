(function () {
    'use strict';

    cmmApp.directive('cmmTaskBoard', [
        'apiClient', function(apiClient) {
        return {
            link: function(scope, element, attrs) {
                var modal = $(element).find('#editor'),
                    openEditor = function(title) {
                        modal.find('.modal-title').text(title);
                        modal.modal({ show: true });
                    },
                    raiseOnChange = function () {                       
                        if (scope.onChange) {
                            var eventData = {
                                tasksCount: [],
                                boardId: scope.boardId
                            };

                            for (var i in scope.dataSource) {
                                eventData.tasksCount.push(scope.dataSource[i].tasks.length);
                            }

                            scope.onChange(eventData);
                        }
                    };

                scope.statusesCount = 1;
                scope.expandedTasks = [];
                scope.sortableOptions = {
                    connectWith: '.board-tasks',
                    cursor: 'move',
                    handle: '.task-handle',
                    out: function(e, ui) {
                        var taskId = ui.item.attr('data-task-id'),
                            statusId = $(e.target).attr('data-status-id');

                        scope.$apply(function () {
                            var allTasks = [],
                                status,
                                task;

                            for (var i in scope.dataSource) {
                                allTasks = allTasks.concat(scope.dataSource[i].tasks);
                            }

                            status = Cmm.getById(scope.dataSource, statusId);
                            task = Cmm.getById(allTasks, taskId);

                            task.status = { id: status.id };
                            apiClient.put('EmployeeTasks', task).then(function() {
                                raiseOnChange();
                            });
                        });
                    }
                };

                apiClient.get('EmployeeTaskStatuses').then(function (statuses) {                    
                    scope.dataSource = statuses;
                    scope.statusesCount = scope.dataSource.length;
                    
                    apiClient.get('EmployeeTasks', scope.boardId ? { boardId: scope.boardId } : null).then(function(tasks) {
                        for (var i in scope.dataSource) {
                            scope.dataSource[i].tasks = [];
                        }

                        for (var i in tasks) {
                            var task = tasks[i],
                                status = Cmm.getById(scope.dataSource, task.status.id);

                            status.tasks.push(task);
                        }

                        raiseOnChange();
                    });
                });

                scope.isExpanded = function (t) {
                    return scope.expandedTasks.indexOf(t.id) != -1;
                };

                scope.onExpandClick = function (t) {
                    if (scope.isExpanded(t)) {
                        scope.expandedTasks.splice(scope.expandedTasks.indexOf(t.id), 1);
                    } else {
                        scope.expandedTasks.push(t.id);
                    }
                };

                scope.onDeleteClick = function (t) {
                    var s = Cmm.getById(scope.dataSource, t.status.id);
                    var p = EditorHelper.remove(apiClient, 'EmployeeTasks', t, s.tasks);

                    if (p) {
                        p.then(function () {
                            raiseOnChange();
                        });
                    }
                }

                scope.onAddClick = function () {
                    scope.currentTask = { status: { id: scope.dataSource[0].id } };

                    if (scope.boardId) {
                        scope.currentTask.board = { id: scope.boardId };
                    }

                    openEditor(WebCommon.Add);
                };

                scope.onEditClick = function (t) {
                    scope.currentTask = $.extend({}, t, true);
                    openEditor(WebCommon.Edit);
                };

                scope.onSaveClick = function () {
                    var s = Cmm.getById(scope.dataSource, scope.currentTask.status.id);
                    EditorHelper.save(apiClient, 'EmployeeTasks', scope.currentTask, s.tasks).then(function() {
                        raiseOnChange();
                    });
                }
            },
            scope: {
                boardId: '=',
                onChange: '='
            },
            restrict: 'E',
            templateUrl: '/Template/TaskBoard'
        };
    }]);
}());