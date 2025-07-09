// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ContactSubmit(form) {
    var form = document.querySelector('form');

    var formData = new FormData(form);
    //normally there would be validation here to make sure the form is filled out correctly and there aren't any malicious inputs

    //example of how the form would be submitted, doesn't work without a backend to handle the request
    // fetch('/Contact/Submit', {
    //     method: 'POST',
    //     body: formData
    // })
    // .then(response => response.json())
    // .then(data => {
    //     if (data.success) {
    //         alert('Form submitted successfully!');
    //     } else {
    //         alert('Error submitting form: ' + data.error);
    //     }
    // })
    // .catch(error => {
    //     console.error('Error:', error);
    //     alert('An error occurred while submitting the form.');
    // });
    form.reset();
    return false;
}