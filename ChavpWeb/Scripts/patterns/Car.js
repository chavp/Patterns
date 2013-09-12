// A car "class"
function Car(model) {
    var self = this;

    self.model = model;
    self.color = "silver";
    self.year = "2012";

    self.getInfo = function () {
        return self.model + " " + self.year;
    };

}