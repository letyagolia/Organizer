//Вывод всех папок
$('#all').click(getAllNotes);

//Вывод папок по категории
$('#ctg').delegate('.bcateg', 'click', function(e){
    GetFolderByCategory(e.target.id);
});

//Вывод записей по папке
$('#content').delegate('.bfold', 'click', function(e){
    getNotesByFolder(e.target.id);
});

/////////////////////////////////////////////////////////////////////////////////////////////


//Кнопка "Новая категория"
$('#newCtg').click(function(){
    $('#content').html(CreateCategoryForm());
    
});

//Создание новой категории
$('#content').delegate("#createCategoryBtn","click", function(e){
    createCategory(document.forms.createForm.title.value);
});

//////////////////////////////////////////////////////////////////////////////////////////////

//Кнопка "Новая папка"
$('#crud').delegate(".newFld","click", function(e){
    $('#content').html(CreateFolderForm(e.target.id));
    $('#crud').html('');
});
//Кнопка "Добавить" папку
$('#content').delegate(".createFoldBtn", "click", function(e,b){
    createFolder(e.target.id, document.forms.createFldForm.name.value);
});

//////////////////////////////////////////////////////////////////////////////////////////////


//Удалить категорию
$('#delete').delegate(".deleteCBtn", "click", function(e){
    confirm('Удалить категорию?');
    deleteCategory(e.target.id);
});

//Удалить папку
$('#delete').delegate(".deleteFBtn", "click", function(e){
    confirm('Удалить папку?');
    deleteFolder(e.target.id);
});

///////////////////////////////////////////////////////////////////////////////////////////////

//Кнопка "Создать заметку"
$('#crud').delegate(".newNote", "click", function(e){
    $('#content').html(createNoteForm(e.target.id));
});
//Создать
$('#content').delegate("#createNoteBtn", "click", function(a){
    let don = Boolean(false);
    createNote(document.forms.createNoteForm.folderId.value, document.forms.createNoteForm.name.value, document.forms.createNoteForm.text.value, document.forms.createNoteForm.dateFrom.value, document.forms.createNoteForm.dateTo.value, document.forms.createNoteForm.importance.value, don);
})

////////////////////////////////////////////////////////////////////////////////////////////////

//Удалить запись
$('#content').delegate(".deleteNBtn", "click", function(e)
                      {
    confirm('Удалить запись?');
    deleteNote(e.target.id);
});

////////////////////////////////////////////////////////////////////////////////////////////////

//Изменить запись
$('#content').delegate(".updateNBtn", "click", function(e){
    getNoteById(e.target.id);
});

$('#content').delegate(".updateNoteBtn", "click", function(a){
    let z = Boolean(false);
    updateNote(a.target.id, document.forms.updateNoteForm.folderId.value, document.forms.updateNoteForm.name.value, document.forms.updateNoteForm.text.value, document.forms.updateNoteForm.dateFrom.value, document.forms.updateNoteForm.dateTo.value, document.forms.updateNoteForm.importance.value, z);
});

$('#content').delegate(".back", "click", function(e){
    getNotesByFolder(e.target.id);
})





