var PortofolioViewModel = function (id, statement, seriesCollection) {
    var self = this;
    self.Id = id;
    self.Statement = ko.observable(statement);
    self.SeriesCollection = ko.observableArray(ko.utils.arrayMap(seriesCollection, function (series) {
        return new SeriesViewModel(series.Id, series.Title, series.Description, series.TitleImage, series.Projects);
    }));

    self.AddSeries = function () {
        self.SeriesCollection.push(new SeriesViewModel('', '', '', new ImageViewModel('', '', '', '', '', guid()), []));
    }

    self.RemoveSeries = function (series) {
        self.SeriesCollection.remove(series);
    }
}