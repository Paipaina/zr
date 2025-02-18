import request from '@/utils/request'


export function list(query){
    return request({
        url: '/business/Teacher/list',
        method: 'get',
        params: query,
    })
}