(function () {
    'use strict';

    cmmApp.controller('EmployeeTaskController', ['apiClient', '$scope', function (apiClient, $scope) {
        $scope.statusesCount = 1;
        $scope.expandedTasks = [];

        apiClient.get('EmployeeTaskStatuses').then(function (data) {
            $scope.dataSource = { statuses: data };
            $scope.statusesCount = $scope.dataSource.statuses.length;

            apiClient.get('EmployeeTasks').then(function (data) {
                $scope.dataSource.tasks = data;
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
            if (confirm(WebCommon.ConfirmDelete)) {
                apiClient.delete('EmployeeTasks', t.id).then(function() {
                    $scope.dataSource.tasks.splice($scope.dataSource.tasks.indexOf(t), 1);
                });
            }
        }

    }]);
}());