var SeriesViewModel = function (id, title, description, titleImage, projects) {
    var self = this;
    self.Id = ko.observable(id);
    self.Title = ko.observable(title);
    self.Description = ko.observable(description);
    self.TitleImage = new ImageViewModel(titleImage);

}