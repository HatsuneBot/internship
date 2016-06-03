$(document).ready(function () {
    $( 'li' ).each(function( index, elem ) {
        $( elem ).prepend( '<b>' + index + ': </b>' );
    });
});