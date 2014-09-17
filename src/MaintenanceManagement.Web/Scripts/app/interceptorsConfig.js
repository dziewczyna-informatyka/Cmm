(function () {
    'use strict';

    cmmApp.config(['$httpProvider', function ($httpProvider) {
        $httpProvider.interceptors.push('blockuiInterceptor');
        $httpProvider.interceptors.push('errorInterceptor');
    }]);
}());