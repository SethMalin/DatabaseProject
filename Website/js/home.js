$(document).ready(function () {

    loadGames();
    addGame();
    saveChanges();
    search();
});

function loadGames() {
    clearGameTable();
    var contentRows = $('#contentRows');

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44387/games',
        success: function (gameArray) {
            $.each(gameArray, function (index, game) {
                var gameID = game.gameID;
                var title = game.title;
                var genre = game.genre;
                var rating = game.rating;
                var company = game.company;
                var console = game.console;

                var row = '<tr>';
                row += '<td><button type="button" class="btn btn-link" onclick="displayDetails(' + gameID + ')">' + title + '</button></td>';
                row += '<td>' + genre + '</td>';
                row += '<td>' + rating + '</td>';
                row += '<td>' + company + '</td>';
                row += '<td>' + console + '</td>';
                row += '<td><button type="button" class="btn btn-info" onclick="showEditForm(' + gameID + ')">Edit</button></td>';
                row += '<td><button type="button" class="btn btn-danger" onclick="deleteGame(' + gameID + ')">Delete</button></td>';
                row += '</tr>';

                contentRows.append(row);
            })

        },
        error: function () {
            $('#error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));
        }
    });
}

function displayDetails(gameID) {
    $('#error-messages').empty();
    $('#gameTabl').hide();
    $('#display-details').show();

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44387/game/' + gameID,
        success: function (data, status) {

            $('#display-title').text(data.title);
            $('#display-genre').text(data.genre);
            $('#display-rating').text(data.rating);
            $('#display-director').text(data.director);
            $('#display-composer').text(data.composer);
            $('#display-artist').text(data.artist);
            $('#display-company').text(data.company);
            $('#display-year').text(data.year);
            $('#display-console').text(data.console);

        },
        error: function () {
            $('#error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));
        }
    })

}

function displayMain() {
    $('#display-details').hide();
    $('#gameTabl').show();
    loadGames();
}

function addGame() {

    $('#add-button').click(function (event) {

        var haveValidationErrors = checkAndDisplayValidationErrors($('#add-form').find('input'));

        if (haveValidationErrors) {
            return false;
        }

        if ($('#add-year').val().length != 4) {
            $('#error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('The release year must be 4 digits long.'));
            return false;
        }

        $.ajax({
            type: 'POST',
            url: 'https://localhost:44387/game',
            data: JSON.stringify({

                title: $('#add-title').val(),
                genre: $('#add-genre').val(),
                rating: $('#add-rating').val(),
                director: $('#add-director').val(),
                composer: $('#add-composer').val(),
                artist: $('#add-artist').val(),
                company: $('#add-company').val(),
                year: $('#add-year').val(),
                console: $('#add-console').val()
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function () {
                $('#error-messages').empty();
                title: $('#add-title').val();
                genre: $('#add-genre').val();
                rating: $('#add-rating').val();
                director: $('#add-director').val();
                composer: $('#add-composer').val();
                artist: $('#add-artist').val();
                company: $('#add-company').val();
                year: $('#add-year').val();
                console: $('#add-console').val();
                clearGameTable();
                loadGames();
                /*clears for the next add*/
                $('#add-title').val('');
                $('#add-genre').val('');
                $('#add-rating').val('');
                $('#add-director').val('');
                $('#add-composer').val('');
                $('#add-artist').val('');
                $('#add-company').val('');
                $('#add-year').val('');
                $('#add-console').val('');
            },
            error: function () {
                $('#error-messages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Error calling web service. Please try again later.'));
            }
        })
        cancelAdd();
    });
}

function clearGameTable() {
    $('#contentRows').empty();
}

function showAddGame() {
    $('#error-messages').empty();
    $('#gameTabl').hide();
    $('#add-form').show();
}

function cancelAdd() {
    $('#error-messages').empty();
    $('#add-form').hide();
    $('#gameTabl').show();

}

function hideEditForm() {
    $('#error-messages').empty();

    $('#edit-title').val('');
    $('#edit-genre').val('');
    $('#edit-rating').val('');
    $('#edit-director').val('');
    $('#edit-composer').val('');
    $('#edit-artist').val('');
    $('#edit-company').val('');
    $('#edit-year').val('');
    $('#edit-console').val('');

    $('#gameTabl').show();
    $('#edit-form').hide();
}

function showEditForm(gameID) {
    $('#error-messages').empty();
    $('#gameTabl').hide();
    $('#edit-form').show();

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44387/game/' + gameID,
        success: function (data, status) {

            $('#edit-gameID').val(data.gameID);
            $('#edit-title').val(data.title);
            $('#edit-genre').val(data.genre);
            $('#edit-rating').val(data.rating);
            $('#edit-director').val(data.director);
            $('#edit-composer').val(data.composer);
            $('#edit-artist').val(data.artist);
            $('#edit-company').val(data.company);
            $('#edit-year').val(data.year);
            $('#edit-console').val(data.console);

        },
        error: function () {
            $('#error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later. GET'));
        }
    })

    $('#gameTableDiv').hide();
    $('#editFormDiv').show();
}

function clearSearch() {
    $('#search-term').val('');
    clearGameTable();
    loadGames();
}

function search() {

    $('#search-button').click(function (event) {
        $('#error-messages').empty();

        clearGameTable();
        var contentRows = $('#contentRows');

        var url = 'https://localhost:44387/game/' + $('#search-category').val() + '/' + $("#search-term").val();

    $.ajax({
        type: 'GET',
        url: url,
        success: function (gameArray) {
            $.each(gameArray, function (index, game) {

                var gameID = game.gameID;
                var title = game.title;
                var genre = game.genre;
                var rating = game.rating;
                var director = game.director;
                var composer = game.composer;
                var artist = game.artist;
                var company = game.company;
                var year = game.year;
                var console = game.console;

                var row = '<tr>';
                row += '<td>' + title + '</td>';
                row += '<td>' + genre + '</td>';
                row += '<td>' + rating + '</td>';
                row += '<td>' + director + '</td>';
                row += '<td>' + composer + '</td>';
                row += '<td>' + artist + '</td>';
                row += '<td>' + company + '</td>';
                row += '<td>' + year + '</td>';
                row += '<td>' + console + '</td>';
                row += '</tr>';

                contentRows.append(row);
            })

        },
        error: function () {
            if ($('#search-term').val() == '') {
                $('#error-messages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Please enter a search term'));

            }
            if ($('#search-category').val() == 'error') {
                $('#error-messages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Please enter a search category'));

            }
            //else {
            //    $('#error-messages')
            //    .append($('<li>')
            //        .attr({ class: 'list-group-item list-group-item-danger' })
            //        .text('Please make sure you selected a category and have input text to search for.'));
            //}
        }
        })
    })
}

function saveChanges() {
    $('#save-changes-button').click(function (event) {

        var haveValidationErrors = checkAndDisplayValidationErrors($('#edit-form').find('input'));

        if (haveValidationErrors) {
            return false;
        }

            if ($('#edit-year').val().length != 4) {
                $('#error-messages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('The release year must be 4 digits long.'));
                return false;
            }

        $.ajax({
            type: 'PUT',
            url: 'https://localhost:44387/game/' + $('#edit-gameID').val(),
            data: JSON.stringify({
                gameID: $('#edit-gameID').val(),
                title: $('#edit-title').val(),
                genre: $('#edit-genre').val(),
                rating: $('#edit-rating').val(),
                director: $('#edit-director').val(),
                composer: $('#edit-composer').val(),
                artist: $('#edit-artist').val(),
                company: $('#edit-company').val(),
                year: $('#edit-year').val(),
                console: $('#edit-console').val()
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function () {
                $('#errorMessage').empty();
                hideEditForm();
                loadGames();
            },
            error: function () {
                $('#error-messages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Error calling web service. Please try again later.PUT'));
            }
        })
    })
}

function deleteGame(gameID) {
    if (confirm("Are you sure you want to delete this item?")) {
        $.ajax({
            type: 'DELETE',
            url: 'https://localhost:44387/game/' + gameID,
            success: function () {
                loadGames();
            }
        });
    }
}

function checkAndDisplayValidationErrors(input) {
    $('#error-messages').empty();

    var errorMessages = [];

    input.each(function () {
        if (!this.validity.valid) {
            var errorField = $('label[for=' + this.id + ']').text();
            errorMessages.push(errorField + ' ' + this.validationMessage);
        }
    });

    if (errorMessages.length > 0) {
        $.each(errorMessages, function (index, message) {
            $('#error-messages').append($('<li>').attr({ class: 'list-group-item list-group-item-danger' }).text(message));
        });
        // return true, indicating that there were errors
        return true;
    } else {
        // return false, indicating that there were no errors
        return false;
    }
}