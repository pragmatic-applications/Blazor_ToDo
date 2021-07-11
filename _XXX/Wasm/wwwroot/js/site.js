$(function () {

  if ($("a.confirmDeletion").length) {
    $("a.confirmDeletion").click(() => {
      if (!confirm("Confirm deletion")) return false;
    });
  }

  if ($("div.alert.notification").length) {
    setTimeout(() => {
      $("div.alert.notification").fadeOut();
    }, 2000);
  }

});

function readURL(input) {
  if (input.files && input.files[0]) {
    let reader = new FileReader();

    reader.onload = function (e) {
      $("img#imgpreview").attr("src", e.target.result).width(200).height(200);
    };

    reader.readAsDataURL(input.files[0]);
  }
}

//// VK


function confirmDelete(uniqueId, isDeleteClicked) {

  //window.preventDefault();

  var deleteSpan = 'deleteSpan_' + uniqueId;
  var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

  if (isDeleteClicked) {
    $('#' + deleteSpan).hide();
    $('#' + confirmDeleteSpan).show();
  }
  else {
    $('#' + deleteSpan).show();
    $('#' + confirmDeleteSpan).hide();
  }
}


//// VK

//==========
//MainContent
//CKEDITOR.replace( 'MainContent' );


//function CKEditor(MainContent) {

//  CKEDITOR.replace(MainContent);
//}

function CKEditor() {

  CKEDITOR.replace('MainContent');
}

//window.CKEditor() = function () {

//  CKEDITOR.replace('MainContent');
//}


window.CKEDITOR =
{
  ckEditor: function () {
    CKEDITOR.replace("Content");
  },

  //document.getElementById(id)
  ckEditor1: function (id) {
    CKEDITOR.replace(document.getElementById(id));
  }

};

////=============
//(function () {

//  window.CKEDITORFunctions = {

//    createQuill: function (quillElement) {
//      CKEDITOR.replace('MainContent');

//      //new Quill(quillElement, options);

//    }

//  };

//})();

////=========
//(function () {

//  window.QuillFunctions = {

//    createQuill: function (quillElement) {

//      var options = {

//        debug: 'info',

//        modules: {

//          toolbar: '#toolbar'

//        },

//        placeholder: 'Compose an epic...',

//        readOnly: false,

//        theme: 'snow'

//      };

//      // set quill at the object we can call

//      // methods on later

//      new Quill(quillElement, options);

//    }

//  };

//})();

