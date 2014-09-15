(function () {
    'use strict';

    cmmApp.controller('ProjectDetailsController', [
        'apiClient', '$scope', function(apiClient, $scope) {
            $scope.projectId = $('#project-id').val();

            apiClient.get('TaskBoards', { projectId: $scope.projectId }).then(function(data) {
                $scope.boards = data;
            });
        }
    ]);
}());