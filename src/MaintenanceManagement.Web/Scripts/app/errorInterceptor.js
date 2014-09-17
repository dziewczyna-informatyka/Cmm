(function () {
    'use strict';

    cmmApp.factory('errorInterceptor', [
        '$q', function ($q) {
            var openErrorWindow = function() {
                $('#error-modal').modal('show');
            }
            return {                                
                'requestError': function (rejection) {

                    openErrorWindow();

                    return $q.reject(rejection);
                },
                'responseError': function (rejection) {

                    openErrorWindow();

                    return $q.reject(rejection);
                }
            };
        }
    ]);
}());