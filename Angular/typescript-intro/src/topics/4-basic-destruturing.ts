interface  AudioPlayer{
    audioVolume: number;
    songDuration: number;
    song: string;
    details: Details;
}

interface Details{
    author: string;
    year: number;
}

const audioPlayer: AudioPlayer={
    audioVolume: 90,
    songDuration: 36,
    song: 'Misery Business',
    details: {
        author: 'Halley Williams',
        year: 2007
    }
};

console.log('song' , audioPlayer.song);
console.log('duración', audioPlayer.songDuration);
console.log('audioVolume', audioPlayer.audioVolume);

const {song: anotheSong, songDuration: duracion, audioVolume, details: {author}} = audioPlayer;
console.log({anotheSong, duracion, audioVolume});

const song = 'New Song';

const {details}= audioPlayer;
console.log({author});

//Destruccio´pon de arreglos
// const team7: string[]= ['Naruto', 'Sasuke', 'Sakura'];
// console.log('personaje3', team7[3] || 'No encontrado');

// const sakura = team7[3] || 'No encontrado';
// console.log('personaje 3' , sakura);

// const [naruto, Sasuke, sakura]: string[]= ['Naruto', 'Sasuke', 'Sakura'];
const [, , sakura= 'No encontrado']: string[]= ['Naruto', 'Sasuke'];
console.log(sakura);

export{};