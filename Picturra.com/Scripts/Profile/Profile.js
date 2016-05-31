var ProfileViewModel = function (id, name, about, image, portfolio) {
    var self = this;
    self.Id = id;
    self.Name = ko.observable(name);
    self.About = ko.observable(about);
    self.Image = new ImageViewModel(image.Id, image.Url, image.Caption, image.PublicKey, image.Name, guid());
    self.Portfolio = new PortfolioViewModel(portfolio.Id, portfolio.Statement, portfolio.SeriesCollection);
}