// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const test = () => {
    console.log("hello world");
    return "Hello world";
};

const snackbar = (type,message) => {
    var n = new Noty({
            type: type,
            layout: 'topRight',
            dismissQueue: false,
            force: false,
            maxVisible: 1,
            theme: 'metroui',
            text: message,
            timeout: 3000,
            progressBar: true,
        });
    n.show();
};
