function getAllNotes()
{
    $.ajax(
    {
        type: 'GET',
        url: 'http://localhost:3764/api/note',
        dataType: "json",
        success: function(data)
        {
            let note = "";
            data.forEach(function(item)
            {
                note += noteCard(item.id, item.name, item.text, item.dateFrom, item.dateTo, item.importance, item.done);
            });
            $('#content').html(note);
            $('#crud').html('');
            $('#delete').html('');
           
        }
    });
}

function getNoteById(id)
{
    $.ajax(
    {
        type: 'GET',
        url: `http://localhost:3764/api/note/${id}`,
        dataType: "json",
        success: function(data)
        {
            $('#content').html(updateNoteForm(data.id, data.name, data.text, data.dateFrom, data.dateTo, data.importance, data.folderId, data.done));
            $('#crud').html('');
            $('#delete').html('');
        }
    });
}
function getNoteByIdDone(id, done)
{
    $.ajax(
    {
        type: 'GET',
        url: `http://localhost:3764/api/note/${id}`,
        dataType: "json",
        success: function(data)
        {
            updateNote(data.id, data.folderId, data.name, data.text, data.dateFrom, data.dateTo, data.importance, done);
        }
    });
}


function getNotesByFolder(id)
{
    $.ajax(
    {
        type: 'GET',
        url: `http://localhost:3764/api/note/folder/${id}`,
        dataType: "json",
        success: function(data)
        {
            let note = "";
            data.forEach(function(item)
            {
                note += noteCard(item.id, item.name, item.text, item.dateFrom, item.dateTo, item.importance, item.done);
            });
            $('#content').html(note);
            $('#crud').html(createNoteButton(id));
            $('#delete').html(deleteFldButton(id));
        }
    });
}

function createNote(folderId, name, text, dateFrom, dateTo, importance, done)
{
    $.ajax({
        type: 'POST',
        url: 'http://localhost:3764/api/note',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: `{"FolderId": "${folderId}", "Name": "${name}", "Text": "${text}", "DateFrom": "${dateFrom}", "DateTo": "${dateTo}", "Importance": "${importance}", "Done": "${done}"}`,
        success: function(data){
            getAllNotes();
            getAllCategories();
        },
        error: function (request, status, error) {
        console.log(request.responseText);
        }
    });
}

function deleteNote(id)
{
    $.ajax({
        type: 'DELETE',
        url: `http://localhost:3764/api/note/${id}`,
        dataType: "json",
        success: function(data){
            getAllNotes();
            getAllCategories();
        }
        
    });
}

function updateNote(id, folderId, name, text, dateFrom, dateTo, importance, done){
    $.ajax({
        type: 'PUT',
        url: 'http://localhost:3764/api/note',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: `{
                    "Id": "${id}",
                    "FolderId": "${folderId}",
                    "Name": "${name}", 
                    "Text": "${text}", 
                    "DateFrom": "${dateFrom}", 
                    "DateTo": "${dateTo}", 
                    "Importance": "${importance}",
                    "Done": "${done}"
                }`,
        success: function(data){
            console.log(id, folderId, name, text, dateFrom, dateTo, importance, done);
            getAllNotes();
            getAllCategories();
        },
        error: function (request, status, error) {
        console.log(request.responseText);
        }
    });
}
