(function () {
    'use strict';

    cmmApp.directive('cmmDatePicker', function () {
        return {
            link: function (scope, element, attrs) {
                var input = $(element).find('input'),
                    datePicker = input.datepicker({ format: 'dd-mm-yyyy' }),                    
                    getValue = function() {
                        return scope.$eval('m.' + scope.schema.field, { m: scope.model });
                    }

                scope.$watch('model', function() {
                    input.val(getValue());
                }, true);

                datePicker.on('changeDate', function () {
                    datePicker.datepicker('hide');

                    scope.model[scope.schema.field] = input.val();
                });
            },
            scope: {
                model: '=',
                schema: '='
            },
            restrict: 'E',
            template: '<input id="f-{{schema.field}}" type="text" class="form-control" placeholder="{{schema.title}}" />'
        };
    });
}());