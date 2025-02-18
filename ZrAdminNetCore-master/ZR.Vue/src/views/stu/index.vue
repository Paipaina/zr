<template>
  <div class="app-container">
    <!-- 搜索 -->
    <el-form :model="queryParms" ref="queryForm" :inline="true" v-show="showSearch">
      <el-form-item label="学生姓名" prop="sname">
        <el-input v-model="queryParms.sname" placeholder="请输入学生姓名" clearable @keyup.enter="handleQuery" />
      </el-form-item>
      <el-form-item label="学生序号" prop="sno">
        <el-input v-model="queryParms.sno" placeholder="请输入学生序号" clearable @keyup.enter="handleQuery" />
      </el-form-item>
      <el-form-item label="学生性别" prop="ssex">
        <el-select v-model="queryParms.ssex" placeholder="请选择学生性别" clearable @change="handleQuery">
          <el-option label="男" value="男"></el-option>
          <el-option label="女" value="女"></el-option>
        </el-select>
      </el-form-item>
      <el-form-item>
        <el-button type="primary" icon="el-icon-search" @click="handleQuery">搜索</el-button>
        <el-button icon="el-icon-refresh" @click="resetQuery">重置</el-button>
      </el-form-item>
    </el-form>

    <el-table :key="tableKey" :data="dataList" ref="table" border>
      <el-table-column prop="sno" label="学生序号" width="180" show-overflow-tooltip></el-table-column>
      <el-table-column prop="sname" label="学生姓名" width="180" show-overflow-tooltip></el-table-column>
      <el-table-column prop="sage" label="学生年龄" width="180" show-overflow-tooltip></el-table-column>
      <el-table-column prop="ssex" label="学生性别" width="180" show-overflow-tooltip></el-table-column>
      <el-table-column prop="sbirthday" label="生日" width="180" show-overflow-tooltip></el-table-column>
      <el-table-column label="操作" align="center" width="180" fixed="right">
        <template slot-scope="scope">
          <el-button size="mini" type="text" icon="el-icon-edit" @click="handleUpdate(scope.row)">修改</el-button>
          <el-button size="mini" type="text" icon="el-icon-delete" @click="handleDelete(scope.row)">删除</el-button>
        </template>
      </el-table-column>
    </el-table>

    <!-- 分页组件 -->
    <el-pagination
      :current-page="queryParms.pageNum"
      :page-size="queryParms.pageSize"
      :total="total"
      @current-change="handlePageChange"
      layout="total, prev, pager, next, jumper"
    ></el-pagination>
  </div>
</template>

<script>
import { list } from '@/api/stu/student.js'; 

export default {
  data() {
    return {
      queryParms: {
        pageNum: 1,
        pageSize: 10,
        sname: '', // 学生姓名
        sno: '',   // 学生序号
        ssex: '',  // 学生性别
      },
      showSearch: true,
      dataList: [], // 表格数据
      total: 0, // 总记录数
      tableKey: 0,
    };
  },
  created() {
    this.fetchData();
  },
  methods: {
    // 请求数据的函数
    fetchData() {
      list(this.queryParms)
        .then(res => {
          console.log('Response:', res);
          if (res && res.data) {
            this.dataList = res.data.result || [];
            this.total = res.data.totalNum || 0;
            this.tableKey += 1;
          }
        })
        .catch(error => {
          console.error('请求失败:', error); // 错误处理
        });
    },

    // 页码改变时，调用该函数
    handlePageChange(page) {
      this.queryParms.pageNum = page;
      this.fetchData(); // 根据新的页码获取数据
    },

    handleQuery() {
      console.log('搜索按钮被点击了');
      console.log('查询参数：', this.queryParms); // 打印查询参数，查看是否正确
      this.queryParms.pageNum = 1;
      this.fetchData();
    },
    
    // 重置搜索条件
    resetQuery() {
      this.queryParms.sname = ''; // 修改为 queryParms
      this.queryParms.sno = ''; // 学生序号重置
      this.queryParms.ssex = ''; // 学生性别重置
      this.queryParms.pageNum = 1;
      this.fetchData();
    },

    // 修改按钮点击
    handleUpdate(row) {
      console.log('点击了修改按钮', row); // 确保按钮触发
      // 你可以在这里弹出修改的对话框，进行更新操作
    },

    // 删除按钮点击
    handleDelete(row) {
      console.log('点击了删除按钮', row); // 确保按钮触发
      // 你可以在这里实现删除的操作，调用后端接口删除数据
      // 例如，使用 confirm 弹窗确认删除
      this.$confirm('确定删除此学生?', '提示', {
        confirmButtonText: '删除',
        cancelButtonText: '取消',
        type: 'warning'
      }).then(() => {
        console.log('删除学生', row);
        // 删除后，刷新表格数据
        this.fetchData(); // 根据需要重新拉取数据
      }).catch(() => {
        console.log('取消删除');
      });
    },
  },
};
</script>