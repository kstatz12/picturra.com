var ProjectViewModel = function (id, title, medium, height, width, year, likeCount, images) {
    var self = this;
    self.Id = id;
    self.uniqueId = guid();
    self.Title = ko.observable(title);
    self.Medium = ko.observable(medium);
    self.Height = ko.observable(height);
    self.Width = ko.observable(width);
    self.Year = ko.observable(year);
    self.LikeCount = ko.observable(likeCount);

    self.Images = ko.observableArray(ko.utils.arrayMap(images, function(image) {
        return new ImageViewModel(image.Id, image.Url, image.Caption, image.PublicKey, image.Name, guid());
    }));

    self.AddImage = function () {
        if (self.Images().length < 3) {
            self.Images.push(new ImageViewModel('', '', '', '', ''));
        }
    }

    self.RemoveImage = function (image) {
        self.Images.remove(image);
    }
}