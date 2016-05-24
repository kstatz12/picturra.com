var ViewModel = function(model){
    var self = this;
    self.Profile = new ProfileViewModel(model.Id, model.Name, model.About, model.Image, model.Portfolio);

    self.SaveProfile = function () {
        var data = ko.toJSON(self.Profile);
        console.log(data);
    }
}