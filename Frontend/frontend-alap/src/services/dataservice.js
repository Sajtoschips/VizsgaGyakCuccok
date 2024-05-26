import Axios from 'axios';
Axios.defaults.baseURL = 'http://localhost:3000';

export default {
    getAllLocations(){
        return Axios.get('/locations')
            .then(resp => {
                //console.log(resp.data);
                return resp.data;
            })
            .catch(err =>{
                //console.log(err);
                return Promise.reject(err);
            })
    },
    getById(id, page, limit){
        return Axios.get(`/viewpoints?location=${id}&_page=${page}&_limit=${limit}`)
    
    },
    //posthoz
    rate(kilato){
        return Axios.post('/viewpoints',kilato).then(()=>{});
    },
  

}