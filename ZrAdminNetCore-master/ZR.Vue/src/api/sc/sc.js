import request from '@/utils/request'


export function list(query){
    return request({
        url: '/business/Sc/list',
        method: 'get',
        params: query,
    })
}