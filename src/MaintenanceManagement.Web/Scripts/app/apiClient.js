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
                put: function(resource, entity) {
                    return $http.put('/api-v1/' + resource, entity).then(function(result) {
                        return result.data;
                    });
                },
                post: function(resource, entity) {
                    return $http.post('/api-v1/' + resource, entity).then(function(result) {
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