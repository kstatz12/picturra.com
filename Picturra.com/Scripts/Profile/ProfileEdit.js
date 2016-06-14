var ViewModel = function(model){
    var self = this;
    self.Profile = new ProfileViewModel(model.Id, model.Name, model.About, model.Image, model.Portfolio);
    self.ContactInformation = new ContactViewModel('', '', '', '');
    self.Portfolio = new PortfolioViewModel('', '', []);
    self.LoadPortfolio = function () {

    }

    self.LoadContactInformation = function () {
        var contactInformation;
        if (self.ContactInformation.Id()) {
            $.get("Contact/GetContactInformation", function (data, status) {
                contactInformation = data;
            });
            self.ContactInformation = new ContactViewModel(contactInformation.Id, contactInformation.PhoneNumber, contactInformation.AddressOne, contactInformation.AddressTwo);
        }

        
    }

    self.LoadOrderHistory = function () {
        //TODO: Implement When we do ordering
    }


}