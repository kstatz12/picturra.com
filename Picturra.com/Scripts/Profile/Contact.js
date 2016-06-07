var ContactViewModel = function(email, phone, address1, address2) {
    var self = this;
    self.Id = ko.observable();
    self.Email = ko.observable(email);
    self.Phone = ko.observable(phone);
    self.AddressOne = ko.observable(address1);
    self.AddressTwo = ko.observable(address2);
}