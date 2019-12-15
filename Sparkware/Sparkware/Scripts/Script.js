$('.form-control').on('input', function (e) {
    $('.text-danger').hide();
    $('.alert').hide();
});

$('#Username').on('blur', function () {
    var username = $(this).val().toLowerCase();
    var firstName = $('#FirstName').val().toLowerCase();
    var lastName = $('#LastName').val().toLowerCase();
    if ((username.indexOf(firstName) >= 0) || (username.indexOf(lastName) >= 0)) {
        $(this).prev('span.text-danger').text("Username cannot contain first name or last name!");
        $(this).prev('span.text-danger').show();
    }
});