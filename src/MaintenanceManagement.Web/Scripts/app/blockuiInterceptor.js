(function () {
    'use strict';

    cmmApp.factory('blockuiInterceptor', [
        '$q', function ($q) {
            var count = 0,
                blockUi = function () {
                   
                    if (count == 0) {
                        count++;

                        setTimeout(function() {
                            if (count == 1) {
                                $.blockUI({ message: 'loading' });
                            }
                        }, 50);
                    }                    
                },
                unblockUi = function() {
                    
                    count--;

                    if (count == 0) {
                        $.unblockUI({ message: 'loading' });
                    }
                };

            return {               
                'request': function(config) {
                    blockUi();
                    return config;
                },
                'response': function(response) {
                    unblockUi();
                    return response;
                },

                // optional method
                'responseError': function(rejection) {
                    unblockUi();
                    return $q.reject(rejection);
                }
            };
        }
    ]);

    cmmApp.config(['$httpProvider', function($httpProvider) {
        $httpProvider.interceptors.push('blockuiInterceptor');
    }]);
}());