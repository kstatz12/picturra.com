var ProfileViewModel = function (id, name, about, image) {
    var self = this;
    self.Name = ko.observable(name);
    self.About = ko.observable(about);
    self.Image = new ImageViewModel(image.Id, image.Url, image.Caption, image.PublicKey, image.Name);

    self.SaveProfile = function () {
        var data = {
            Name: self.Name(),
            About: self.About(),
            Image: ko.ko.toJSON(self.Image)
        };
        $.ajax({
            url: "Profile/Save",
            type: "POST",
            data: data,
            success: function(d) {
                
            },
            failure: function(d) {
                alert(d);
            }
        });
    }
}