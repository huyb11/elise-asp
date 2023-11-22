// upload img admin
function ChangeImg1(UploadImg1, previewImg1) {
    if (UploadFileImg1.files && UploadFileImg1.fils[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg1.attr('src', e.target.result);
        }
        reader.readAsDataURL(UploadFileImg1.files[0]);
    }
}
function ChangeImg2(UploadImg2, previewImg2) {
    if (UploadImg2.files && UploadImg2.fils[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg2.attr('src', e.target.result);
        }
        reader.readAsDataURL(UploadImg2.files[0]);
    }
}
function ChangeImg3(UploadImg3, previewImg3) {
    if (UploadImg3.files && UploadImg3.fils[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg3.attr('src', e.target.result);
        }
        reader.readAsDataURL(UploadImg3.files[0]);
    }
}
function ChangeImg4(UploadImg4, previewImg4) {
    if (UploadImg4.files && UploadImg4.fils[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg4.attr('src', e.target.result);
        }
        reader.readAsDataURL(UploadImg4.files[0]);
    }
}
function ChangeImg5(UploadImg5, previewImg5) {
    if (UploadImg5.files && UploadImg5.fils[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg5.attr('src', e.target.result);
        }
        reader.readAsDataURL(UploadImg5.files[0]);
    }
}