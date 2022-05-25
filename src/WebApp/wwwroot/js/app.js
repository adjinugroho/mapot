function ShowNotification(type, message) {
    var toastClass = '';
    var toastTitle = '';
    var toastIcon = '';

    switch (type) {
        case 'Error':
            toastClass = 'bg-danger';
            toastTitle = 'Error';
            toastIcon = 'fas fa-times';
            break;
        case 'Success':
            toastClass = 'bg-success';
            toastTitle = 'Success';
            toastIcon = 'fas fa-check';
            break;
        case 'Info':
            toastClass = 'bg-info';
            toastTitle = 'Info';
            toastIcon = 'fas fa-envelope';
            break;
        case 'Warning':
            toastClass = 'bg-warning';
            toastTitle = 'Warning';
            toastIcon = 'fas fa-exclamation';
            break;
    }

    $(document).Toasts('create', {
        class: toastClass,
        autohide: true,
        delay: 3000,
        icon: toastIcon,
        title: toastTitle,
        body: message
    })
};