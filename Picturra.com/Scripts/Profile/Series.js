var SeriesViewModel = function (id, title, description, titleImage, projects) {
    var self = this;
    self.Id = id;
    self.uniqueId = guid();
    self.Title = ko.observable(title);
    self.Description = ko.observable(description);
    self.TitleImage = new ImageViewModel(titleImage);
    self.Projects = observableArray(ko.utils.arrayMap(projects, function(project) {
        return new ProjectViewModel(project.Id, project.Title, project.Medium, project.Height, project.Width, project.Year, project.LikeCount, project.Images);
    }));

    self.AddProject = function() {
        self.Projects.push(new ProjectViewModel('', '', '', '', '', '', []));
    }

    self.RemoveProject = function(project) {
        self.Projects.remove(project);
    }
}