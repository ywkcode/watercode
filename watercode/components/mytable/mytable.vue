<template>
	<view>
		<uni-table border stripe emptyText="暂无更多数据" >
				  		     <!-- 表头行 -->
				  		     <uni-tr>
				  		         <uni-th align="center">监测日期</uni-th>
				  		         <uni-th align="center">监测数据</uni-th>
				  		         <uni-th align="left">状态描述</uni-th>
				  		     </uni-tr>
				  		     <!-- 表格数据行 -->
				  		     <uni-tr>
				  		         <uni-td>2022-03-02 17:01</uni-td>
				  		         <uni-td>12</uni-td>
				  		         <uni-td>正常</uni-td>
				  		     </uni-tr>
				  		   <uni-tr>
				  		       <uni-td>2022-03-02 17:02</uni-td>
				  		       <uni-td>13</uni-td>
				  		       <uni-td>正常</uni-td>
				  		   </uni-tr>
				  		 <uni-tr>
				  		     <uni-td>2022-03-02 17:03</uni-td>
				  		     <uni-td>12</uni-td>
				  		     <uni-td>正常</uni-td>
				  		 </uni-tr>
				  		  <uni-tr>
				  		      <uni-td>2022-03-02 17:04</uni-td>
				  		      <uni-td>12</uni-td>
				  		      <uni-td>正常</uni-td>
				  		  </uni-tr> 
				  	  </uni-table>
	</view>
</template>

<script>
	export default {
		name:"mytable",
		data() {
			return {
				
			};
		}
	}
</script>

<style>

</style>
