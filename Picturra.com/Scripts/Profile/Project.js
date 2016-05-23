var ProjectViewModel = function () {
    var self = this;
    self.TitleImage = new ImageViewModel('', '', '', '', guid());
    self.Title = ko.observable('');
    self.Medium = ko.observable('');
    self.Height = ko.observable('');
    self.Width = ko.observable('');
    self.Year = ko.observable('');
    self.LikeCount = ko.observable('');

    self.Images = ko.observableArray([]);

    self.AddImage = function () {
        if (images.length <= 3) {
            Images.push(new ImageViewModel('', '', '', '', guid()));
        }
    }

    self.RemoveImage = function (image) {
        Images.remove(image);
    }
}