(function () {
    'use strict';

    cmmApp.factory('apiClient', [
        '$http', function ($http) {

            return {
                read: function (resource) {
                    return $http.get('/api-v1/' + resource).then(function (result) {
                        return result.data;
                    });
                }
            }
        }
    ]);
}());