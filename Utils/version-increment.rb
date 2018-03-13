require "yaml"

path = File.expand_path('../.') + "/ProjectSettings/ProjectSettings.asset"
data = YAML::load_file(path)
version = data['PlayerSettings']['bundleVersion']
newVersion = version + 0.0001
newVersion = (newVersion * 10000).round / 10000.0
data['PlayerSettings']['bundleVersion'] = newVersion

packed = YAML.dump(data)
streamed = StringIO.new(packed)
streamed.pos = 4
trimmed = streamed.read

target = File.open(path, 'w')
target.write("%YAML 1.1 \n")
target.write("%TAG !u! tag:unity3d.com,2011: \n")
target.write("--- !u!129 &1 \n")
target.write(trimmed)
target.close