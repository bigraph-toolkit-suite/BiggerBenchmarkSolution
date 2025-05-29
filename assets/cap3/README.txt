This file contains execution instructions.

== Requirements
(Check that you have at least Java 17 installed)


java --version


== Execute bigger.jar to generate GrGen.NET files:


java -jar ../bigger.jar --verbose --basepath=./ --host=host.xmi --output=foo \
--sig=sig.xmi --sigM=signatureMetaModel.ecore --metamodel=bigraphMetaModel.ecore \
--rule=nextRule:nextRule-lhs.xmi,nextRule-rhs.xmi \
--rule=appendRule:appendRule-lhs.xmi,appendRule-rhs.xmi \
--rule=returnRule:returnRule-lhs.xmi,returnRule-rhs.xmi \
--tracking=map.json
