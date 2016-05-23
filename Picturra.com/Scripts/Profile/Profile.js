var ProfileViewModel = function (name, about, image) {
    var self = this;
    self.Name = ko.observable(name);
    self.About = ko.observable(about);
    self.Image = new ImageViewModel(image.Id, image.Url, image.Caption, image.PublicKey, guid());
     
}