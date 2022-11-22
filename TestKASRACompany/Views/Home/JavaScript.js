$.ajax({
    method: 'post', url: '/api/Testkasra/test2add', data: JSON.stringify(data), contentType: 'application/json',
    , error: function (request, status, error) {
        alert(request.responseText);
    }
}).then(function (res) {
                console.log('---add--', res);
              //  append(res);
            }). ; 