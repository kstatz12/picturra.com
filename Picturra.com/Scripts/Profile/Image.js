function Upload(attrId) {
    var fileInput = attrId;
    var formData = new FormData();
    formData.append('file', $(fileINput)[0].files[0]);
    $.ajax({
        url: "/Upload/Upload",
        type: "POST",
        data: formData,
        enctype: 'multipart/form-data',
        processData: false,
        contentType: false,
        success: function (data) {
            var retVal = {
                imageUrl: data.Image.ImageUrl,
                imagePublicKey: data.Image.PublicKey
            };
            return retVal;
        },
        failure: function (data) {
            return false;
        }
    });
}

function Delete(publicId) {
    var data = {
        PublicKey: publicId
    };
    $.ajax({
        url: "/Upload/Delete",
        type: "POST",
        data: data,
        success: function (data) {
            return true;
        },
        failure: function (data) {
            return false;
        }
    });
}

var ImageViewModel = function (id, imageUrl, imageCaption, imagePublicKey, imageName, attrId) {
    var self = this;
    self.Id = id;
    self.Url = ko.observable(imageUrl);
    self.Caption = ko.observable(imageCaption);
    self.PublicKey = ko.observable(imagePublicKey);
    self.AttributeId = ko.observable(attrId);
    self.buttonEnable = ko.observable(true);
    self.buttonText = ko.computed(function () {
        return !self.buttonEnable ? "Upload Image" : "Uploading Image";
    });

    self.upload = function () {
        var attr = '#' + attrId;
        var imageUrl = Upload(attr);
        if (imageUrl === false) {
            alert('Image Failed to Upload');
        }
        else {
            self.ImageUrl(imageUrl.imageUrl);
        }
    }

    self.delete = function () {
        if (!Delete(self.ImagePublicKey())) {
            alert("Image Failed to Delete, Please Try again or contact support")
        }
    }
}