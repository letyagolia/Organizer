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
});
//Кнопка "Добавить" папку
$('#content').delegate("#createFoldBtn", "click", function(a,b){
    createFolder(document.forms.createFldForm.categoryId.value, document.forms.createFldForm.name.value);
});

//////////////////////////////////////////////////////////////////////////////////////////////


//Удалить категорию
$('#delete').delegate(".deleteCBtn", "click", function(e){
    deleteCategory(e.target.id);
});

//Удалить папку
$('#delete').delegate(".deleteFBtn", "click", function(e){
    deleteFolder(e.target.id);
});

///////////////////////////////////////////////////////////////////////////////////////////////

//Кнопка "Создать заметку"
$('#crud').delegate(".newNote", "click", function(e){
    $('#content').html(createNoteForm(e.target.id));
});
//Создать
$('#content').delegate("#createNoteBtn", "click", function(a,b,c,d,e,f){
    createNote(document.forms.createNoteForm.folderId.value, document.forms.createNoteForm.name.value, document.forms.createNoteForm.text.value, document.forms.createNoteForm.dateFrom.value, document.forms.createNoteForm.dateTo.value, document.forms.createNoteForm.importance.value)
})





