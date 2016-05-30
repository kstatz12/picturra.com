function Upload(attrId) {
    var formData = new FormData();
    formData.append('file', $(attrId)[0]);
    
}



var ImageViewModel = function (id, imageUrl, imageCaption, imagePublicKey, imageName, attrId) {
    var self = this;

    self.Id = id;
    self.Url = ko.observable(imageUrl);
    self.Caption = ko.observable(imageCaption);
    self.PublicKey = ko.observable(imagePublicKey);
    self.Name = ko.observable(imageName);
    self.AttributeId = '#' + attrId;
    self.buttonEnable = ko.observable(true);
    self.buttonText = ko.computed(function () {
        return !self.buttonEnable ? "Upload Image" : "Uploading Image";
    });


    //functions
    self.upload = function (data, e) {
        var formData = new FormData();
        formData.append('file', e.target.files[0]);
        $.ajax({
            url: "/Upload/Upload",
            type: "POST",
            data: formData,
            enctype: 'multipart/form-data',
            processData: false,
            contentType: false,
            success: function (d) {
                self.Url(d.Image.Url);
            },
            failure: function (d) {
                alert(d);
            }
        });
    }
    self.delete = function () {

    }
}