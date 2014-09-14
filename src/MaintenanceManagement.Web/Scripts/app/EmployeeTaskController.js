(function () {
    'use strict';

    cmmApp.controller('EmployeeTaskController', ['apiClient', '$scope', function (apiClient, $scope) {
        var modal = $(".employee-tasks").find('#editor'),
            openEditor = function(title) {
                modal.find('.modal-title').text(title);
                modal.modal({ show: true });
            };
      
        $scope.statusesCount = 1;
        $scope.expandedTasks = [];

        apiClient.get('EmployeeTaskStatuses').then(function (data) {
            $scope.dataSource = { statuses: data };
            $scope.statusesCount = $scope.dataSource.statuses.length;

            apiClient.get('EmployeeTasks').then(function (data) {
                $scope.dataSource.tasks = data;

                $('.board-tasks').sortable({
                    connectWith: '.board-tasks'
                }).disableSelection();
            });
        });

        $scope.isExpanded = function(t) {
            return $scope.expandedTasks.indexOf(t.id) != -1;
        };

        $scope.onExpandClick = function(t) {
            if ($scope.isExpanded(t)) {
                $scope.expandedTasks.splice($scope.expandedTasks.indexOf(t.id), 1);
            } else {
                $scope.expandedTasks.push(t.id);
            }
        };

        $scope.onDeleteClick = function(t) {            
            EditorHelper.remove(apiClient, 'EmployeeTasks', t, $scope.dataSource.tasks);
        }

        $scope.onAddClick = function () {
            $scope.currentTask = {};
            openEditor(WebCommon.Add);
        };

        $scope.onEditClick = function(t) {
            $scope.currentTask = $.extend({}, t, true);
            openEditor(WebCommon.Edit);
        };

        $scope.onSaveClick = function () {
            EditorHelper.save(apiClient, 'EmployeeTasks', $scope.currentTask, $scope.dataSource.tasks).then(function(data) {
                if (!$scope.currentTask.status) {
                    var e = null;

                    for (var i in $scope.dataSource.tasks) {
                        if ($scope.dataSource.tasks[i].id == $scope.currentTask.id) {
                            e = $scope.dataSource.tasks[i];
                        }
                    }

                    e.status = $.extend({}, $scope.dataSource.statuses[0], true);
                }
            });
        }
    }]);
}());