(function () {
    'use strict';

    cmmApp.factory('apiClient', [
        '$http', function ($http) {

            return {
                read: function (resource) {
                    return $http.get('/api-v1/' + resource).then(function (result) {
                        return result.data;
                    });
                },
                delete: function (resource, id) {
                    return $http.delete('/api-v1/' + resource + '/' + id).then(function (result) {
                        return result.data;
                    });
                }
            }
        }
    ]);
}());