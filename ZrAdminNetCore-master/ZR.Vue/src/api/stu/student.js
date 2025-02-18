import request from '@/utils/request'


export function list(query){
    return request({
        url: '/business/Student/list',
        method: 'get',
        params: query,
    })
}

