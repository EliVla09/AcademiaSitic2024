let colores: string[] = ['Rojo', 'Verde', 'Azul'];

// const refaccion= {
//     nombre: 'filtro',
//     existencia: 50,
//     colores: ['Rojo', 'Negro']
// }

interface Articulo {
    nombre: string,
    existencia: number,
    colores: string[],
    marca?: string
}

const refaccion: Articulo = {
    nombre: 'filtro',
    existencia: 50,
    colores: ['Rojo', 'Negro'],
    // marca: 'Marca'
}

refaccion.marca = 'LTH';
console.log(refaccion);
console.table(refaccion);

// export{}; para un modulo de angular