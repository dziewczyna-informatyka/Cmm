(function () {
    'use strict';

    cmmApp.controller('ProjectDetailsController', [
        'apiClient', '$scope', function(apiClient, $scope) {
            $scope.projectId = $('#project-id').val();
            $scope.onChange = function(e) {
                var todoCount = e.tasksCount[0],
                    inProgressCount = e.tasksCount[1],
                    doneCount = e.tasksCount[2],
                    board = Cmm.getById($scope.boards, e.boardId),
                    state = todoCount == 0 && inProgressCount == 0 ? 'done' :
                        doneCount == 0 && inProgressCount == 0 ? 'open' : 'inProgress';

                board.done = board.inProgress = board.open = false;
                board[state] = true;

                board.isCollapsed = !board.inProgress;
            };;

            apiClient.get('TaskBoards', { projectId: $scope.projectId }).then(function(data) {
                $scope.boards = data;
            });
        }
    ]);
}());