///<signature>
///<summary> Formate la fecha de un post o comentario
// </summary>

// function formatDateTimeNow(fechaString) {
//     const fechaActual = new Date();
//     const fechaPasada = new Date(fechaString);

//     const diferenciaEnMilisegundos = fechaActual - fechaPasada;
//     const segundos = Math.floor(diferenciaEnMilisegundos / 1000);
//     const minutos = Math.floor(segundos / 60);
//     const horas = Math.floor(minutos / 60);
//     const dias = Math.floor(horas / 24);
//     const años = Math.floor(dias / 365);

//     if (años > 0) {
//         return `hace ${años} año${años > 1 ? 's' : ''}`;
//     } else if (dias > 0) {
//         return `hace ${dias} día${dias > 1 ? 's' : ''}`;
//     } else if (horas > 0) {
//         return `hace ${horas} hora${horas > 1 ? 's' : ''}`;
//     } else if (minutos > 0) {
//         return `hace ${minutos} minuto${minutos > 1 ? 's' : ''}`;
//     } else {
//         return `hace ${segundos} segundo${segundos > 1 ? 's' : ''}`;
//     }
// }




function formatDateTimeNow(fechaString) {
    const fechaActual = new Date();
    const fechaPasada = new Date(fechaString);

    const diferenciaEnMilisegundos = fechaActual - fechaPasada;
    const segundos = Math.floor(diferenciaEnMilisegundos / 1000);
    const minutos = Math.floor(segundos / 60);
    const horas = Math.floor(minutos / 60);
    const dias = Math.floor(horas / 24);
    const años = Math.floor(dias / 365);

    if (años > 0) {
        return `hace ${años} año${años > 1 ? 's' : ''}`;
    } else if (dias > 0) {
        return `hace ${dias} día${dias > 1 ? 's' : ''}`;
    } else if (horas > 0) {
        return `hace ${horas} hora${horas > 1 ? 's' : ''}`;
    } else if (minutos > 0) {
        return `hace ${minutos} minuto${minutos > 1 ? 's' : ''}`;
    } else {
        return `hace ${segundos} segundo${segundos > 1 ? 's' : ''}`;
    }
}