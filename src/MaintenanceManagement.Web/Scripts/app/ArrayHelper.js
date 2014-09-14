var Cmm = (function() {
    return {
        getById: function(array, id) {
            var e;

            for (var i in array) {
                if (array[i].id == id) {
                    e = array[i];
                }
            }

            return e;
        }
    };
}());