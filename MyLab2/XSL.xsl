<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version ="1.0" xmlns:xsl = "http://www.w3.org/1999/XSL/Transform">
	<xsl:output method = "html"/>
	<xsl:template match = "ScientificWorksSheet">
		<html>
			<body>
				<table border = "5">
					<TR>
						<th>FullName</th>
						<th>Faculty</th>
						<th>Department</th>
						<th>Position</th>
						<th>Scientific_Work</th>
						<th>Customer</th>
						<th>Address</th>
						<th>Subordination</th>
						<th>Area</th>
					</TR>
					<xsl:for-each select ="//ScientificWork">
						<tr>
							<td>
								<xsl:value-of select ="@FullName"/>
							</td>
							<td>
								<xsl:value-of select ="@Faculty"/>
							</td>
							<td>
								<xsl:value-of select ="@Department"/>
							</td>
							<td>
								<xsl:value-of select ="@Position"/>
							</td>
							<td>
								<xsl:value-of select ="@Scientific_Work"/>
							</td>
							<td>
								<xsl:value-of select ="@Customer"/>
							</td>
							<td>
								<xsl:value-of select ="@Address"/>
							</td>
							<td>
								<xsl:value-of select ="@Subordination"/>
							</td>
							<td>
								<xsl:value-of select ="@Area"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template></xsl:stylesheet>	
							
						