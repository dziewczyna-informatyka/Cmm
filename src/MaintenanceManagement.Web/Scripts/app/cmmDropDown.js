(function () {
    'use strict';

    cmmApp.directive('cmmDropDown', ['apiClient', function (apiClient) {
        return {
            link: function (scope, element, attrs) {
                var select = $(element).find('select'),
                    getValue = function() {
                        return scope.$eval('m.' + scope.field, { m: scope.model });
                    },
                    setValue = function (i) {
                        if (scope.model && scope.dataSource) {
                            scope.model[scope.field] = $.extend({}, scope.dataSource[i], true);
                        }
                    }

                apiClient.get(scope.resource).then(function(data) {
                    scope.dataSource = data;                   
                });
                
                scope.$watch('model', function () {
                    var v = getValue();
                   
                    if (v) {
                        select.val(v.id);
                    } else {
                        setValue(0);
                    }
                }, true);

                select.on('change', function (e) {
                    scope.$apply(function() {
                        for (var i in scope.dataSource) {
                            if (scope.dataSource[i].id == select.val()) {
                                setValue(i);
                            }
                        }
                    });
                });
            },
            restrict: 'E',
            scope: {
                resource: '=',
                field: '=',
                model: '='
            },
            templateUrl: '/Template/DropDown'
        };
    }]);
}());