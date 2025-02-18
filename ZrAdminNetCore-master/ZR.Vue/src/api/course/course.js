import request from '@/utils/request'

export function list(query) {
  return request({
    url: '/business/Course/list',
    method: 'get',
    params: query,
  })
}