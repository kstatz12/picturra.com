(function () {

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
                return data.Image.ImageUrl;
            },
            failure: function (data) {
                return false;
            }
        });
    }

    function Delete(publicId) {

    }
    var ImageViewModel = function (imageUrl, imageCaption, imageName, attrId) {
        var self = this;
        self.ImageUrl = ko.observable(imageUrl);
        self.ImageCaption = ko.observable(imageCaption);
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
        }
    }
})();